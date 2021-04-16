import { Meta, Story } from "@storybook/react/types-6-0";
import ProfileSettingPage from "../pages/ProfileSettingPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/ProfileSettingPage",
    decorators: [StoryRouter()],
    components: ProfileSettingPage,
} as Meta;

const Template: Story = () => <ProfileSettingPage />;

export const Default = Template.bind({});