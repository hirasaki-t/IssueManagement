import { Meta, Story } from "@storybook/react/types-6-0";
import ProjectDisplay from "../components/ProjectDisplay";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/ProjectDisplay",
    decorators: [StoryRouter()],
    components: ProjectDisplay,
} as Meta;

const Template: Story = () => <ProjectDisplay />;

export const Default = Template.bind({});