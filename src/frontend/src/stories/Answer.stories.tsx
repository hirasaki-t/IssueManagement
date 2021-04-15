import { Meta, Story } from "@storybook/react/types-6-0";
import Answer from "../components/Answer";

export default {
    title: "components/Answer",
    components: Answer,
} as Meta;

const Template: Story = () => <Answer />;

export const Default = Template.bind({});